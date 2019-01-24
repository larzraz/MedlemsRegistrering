using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace MedlemsRegistrering
{
    public class MainViewViewModel
    {
        DataContext db = new DataContext();
        public List<Members> Members;
        public ObservableCollection<Members> Member;
        
        public MainViewViewModel()
        {
              Members = db.Members.ToList();

        }


        
    }
}
    
       


      
      



    


