using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatRDemo
{
    public partial class ContactsController
    {
        public class ContractHandler : IRequestHandler<GetContatsFilter, Contact>
        {
            private ContractsContext _contractsContext;

            public ContractHandler(ContractsContext contractsContext)
            {
                _contractsContext = contractsContext;
            }

            public Task<Contact> Handle(GetContatsFilter request, CancellationToken cancellationToken)
            {
                return _contractsContext.Contacts.Where(x => x.Id == request.Id).SingleOrDefaultAsync();
            }
        }
    }
}