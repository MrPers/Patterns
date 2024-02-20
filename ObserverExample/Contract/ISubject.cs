using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.Contract
{
    public interface ISubject
    {
        // Attaches the observer to the publisher.
        void Attach(IObserver observer);

        // Detaches the observer from the publisher.
        void Detach(IObserver observer);

        // Notifies all observers about the event.
        void Notify();
    }

}
