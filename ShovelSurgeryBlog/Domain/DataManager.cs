using ShovelSurgeryBlog.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShovelSurgeryBlog.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextField { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextField = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
