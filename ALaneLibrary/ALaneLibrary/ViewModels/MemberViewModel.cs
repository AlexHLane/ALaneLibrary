using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALaneLibrary.Models;

namespace ALaneLibrary.ViewModels
{
    public class MemberViewModel
    {
        public List<Book> BookCollection { get; set; }
        public List<Member> MemberList { get; set; }
    }
}
