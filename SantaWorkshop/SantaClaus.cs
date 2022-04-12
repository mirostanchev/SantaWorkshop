using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    public class SantaClaus : IObservable
    {
        private readonly List<IObserver> observers;
        private ProductType latestProduct;

        public SantaClaus()
        {
            this.observers = new List<IObserver>();
        }

        public ProductType LatestProduct 
        {
            get
            {
                return this.latestProduct;
            }
            private set
            {
                this.latestProduct = value;
                Notify();
            } 
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void WantsBike()
        {
            this.LatestProduct = ProductType.Bike;
        }

        public void WantsDoll()
        {
            this.LatestProduct = ProductType.Doll;
        }
    }
}
