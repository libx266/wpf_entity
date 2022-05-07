using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Database.Entities
{
    public class Service : WithImage
    {
        public string Title { get; set; }

        [NotMapped]
        public string TITLE
        {
            get => Title;
            set
            {
                Title = value;
                NotifyProperty();
                NotifyData();
            }
        }
        public string Duration { get; set; }

        [NotMapped]
        public string PRICE
        {
            get => String.Format(Properties.Resources.ServiceDuration, Math.Round(Price.ToDecimal() - (Price.ToDecimal() * (discount / 100)), 2), duration / (duration > 480 ? 60 : 1));
            set
            {
                Price = value.ToDecimal(0).ToString();
                Duration = (value.ToDecimal(1) * 60).ToString();
                NotifyProperty();
                NotifyData();
            }
        }

        [NotMapped]
        public string DISCOUNT => discount > 0 ? String.Format(Properties.Resources.ServiceDiscount, discount) : "";

        [NotMapped]
        public string BASEPRICE => discount > 0 ? Math.Round(Price.ToDecimal(), 2).ToString() : "";

        [NotMapped]
        public decimal discount => Discount.ToDecimal();

        protected decimal duration => Duration.ToDecimal();

        public string Price { get; set; }
        public string Discount { get; set; }

    }
}
