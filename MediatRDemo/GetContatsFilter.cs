using MediatR;

namespace MediatRDemo
{
    public partial class ContactsController
    {
        public class GetContatsFilter : IRequest<Contact>
        {
            public int Id { get; set; }
        }
    }
}