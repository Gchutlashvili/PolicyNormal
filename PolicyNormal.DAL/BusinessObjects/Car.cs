using System;
using System.Linq;
using DAL.BusinessObjects;
using DevExpress.Xpo;

namespace PolicyNormal.Module.BusinessObjects
{
    [DSDefaultClassOptions]
    public class Car : DSEntityBase<Car>
    {
        public Car(Session session) : base(session) { }
        [DSAction]
        public string RegistrationNumber { get; set; }
        [Association] public VehicleModel VehicleModel { get; set; }

        public int VehicleYear { get; set; }
        [Association] public XPCollection<Policy> Policies => GetCollection<Policy>(nameof(Policies));
        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);


        }

        protected override void OnSaving()
        {
            base.OnSaving();

            var existingCarsWithSameRegistrationNumber =
                Session.Query<Car>().Where(car => car.RegistrationNumber == RegistrationNumber);

            if (existingCarsWithSameRegistrationNumber.Any())
                throw new Exception();
        }
    }
}