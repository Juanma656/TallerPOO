using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    public class Invoice : IPay
    {
        private ICollection<Product> _product = new List<Product>();
        

        public void AddProduct(Product product)
        {
            _product.Add(product);
        }

        public Invoice()
        {
        }
        decimal payroll=0;
        public decimal ValueToPay()
        {
            
            foreach (Product product in _product)
            {                
                Console.WriteLine(product);
                payroll += product.ValueToPay();
            }
            return payroll;
        }

        public override string ToString()
        {

            return
                $"                                     ============"+
                $"\n\tTOTAL ......................: {$"{ValueToPay():C2}"}";
        }

       
    }
}
