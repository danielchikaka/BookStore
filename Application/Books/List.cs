using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Books {
    public class List {
        public class Query : IRequest<List<BookDto>> { }

        public class Handler : IRequestHandler<Query, List<BookDto>> {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler (DataContext context, IMapper mapper) {
                _mapper = mapper;
                _context = context;
            }

            public async Task<List<BookDto>> Handle (Query request, CancellationToken cancellationToken) {
                var books = await _context.Books
                    .ToListAsync ();

                return _mapper.Map<List<Book>, List<BookDto>> (books);
            }
        }
    }
}