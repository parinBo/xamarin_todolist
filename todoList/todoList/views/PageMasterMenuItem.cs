using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoList.views
{

    public class PageMasterMenuItem
    {
        public PageMasterMenuItem()
        {
            TargetType = typeof(PageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}