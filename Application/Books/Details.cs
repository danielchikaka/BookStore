using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Books {
    public class Details {
        public class Query : IRequest<BookDto> {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, BookDto> {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler (DataContext context, IMapper mapper) {
                _mapper = mapper;
                _context = context;
            }

            public async Task<BookDto> Handle (Query request, CancellationToken cancellationToken) {
                var book = await _context.Books
                    .FindAsync (request.Id);

                if (book == null)
                    throw new RestException (HttpStatusCode.NotFound, new { Activity = "Not found" });

                var bookToReturn = _mapper.Map<Book, BookDto> (book);

                return bookToReturn;
            }
        }
    }
}