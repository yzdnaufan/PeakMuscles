using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTrainer
{
    public class Muscle
    {
        protected string _url;
        protected double count;

        /// <summary>
        /// DON'T USE YET
        /// </summary>
        /// <param name="url"></param>
        public Muscle(string url)
        {
            _url = url;
        }

        /// <summary>
        /// DON'T USE YET
        /// </summary>
        /// <param name="jumlah"></param>
        public virtual void MuscleCount(int jumlah)
        {
            count += jumlah;
        }
    }
    class upper : Muscle
    {
        //DON'T USE YET
        public upper(string url) : base(url)
        {
            this._url=url;
        }

        /// <summary>
        /// DON'T USE YET
        /// </summary>
        /// <param name="jumlah"></param>
        public override void MuscleCount(int jumlah)
        {
            this.count += Convert.ToDouble(jumlah) - 0.5;
        }

        public string? _chest;
        public string? _abs;
        public string? _biceps;
        public string? _triceps;
        public string? _shoulder;
        public string? _backTraps;

        

        public string Chest
        {
            get { return _chest; }
            set { _chest = "https://media.tenor.com/gI-8qCUEko8AAAAM/pushup.gif"; }
        }
        public string Abs
        {
            get { return _abs; }
            set { _abs = "https://seven.app/media/images/Crunches.gif"; }
        }
        public string Biceps
        {
            get { return _biceps; }
            set { _biceps = "https://images.everydayhealth.com/images/best-exercises-for-stronger-arm-muscles-wide-curl.gif"; }
        }
        public string Triceps
        {
            get { return _triceps; }
            set { _triceps = "https://images.everydayhealth.com/images/6-top-triceps-tricep-dip.gif"; }
        }
        public string Shoulder
        {
            get { return _shoulder; }
            set { _shoulder = "https://cdn.shopify.com/s/files/1/1501/0558/files/Lateral_Shoulder_Raises.gif?v=1506073016"; }
        }
        public string BackTraps
        {
            get { return _backTraps; }
            set { _backTraps = "https://miro.medium.com/max/960/1*R7JxVbE2uc18G37natvTgw.gif"; }
        }
    }
    class lower : Muscle
    {
        public string _legs;
        public string _glutes;

        /// <summary>
        /// DON'T USE YET
        /// </summary>
        /// <param name="url"></param>
        public lower(string url) : base(url)
        {
            this._url=url;
        }

        public string Legs
        {
            get { return _legs; }
            set { _legs = "https://seven.app/media/images/image4.gif"; }
        }
        public string Glutes
        {
            get { return _glutes; }
            set { _glutes = "https://www.ammfitness.co.uk/information-advice/wp-content/uploads/2020/04/Glute-Bridge.gif"; }
        }
    }
}