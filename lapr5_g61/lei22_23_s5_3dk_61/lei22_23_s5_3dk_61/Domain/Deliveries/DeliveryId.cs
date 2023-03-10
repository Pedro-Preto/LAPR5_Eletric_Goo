using System;
using DDDSample1.Domain.Shared;
using Newtonsoft.Json;

namespace DDDSample1.Domain.Deliveries
{
    public class DeliveryId : EntityId
    {
        [JsonConstructor]
        public DeliveryId(Guid value) : base(value)
        {
        }

        public DeliveryId(string value) : base(value)
        {
        }

         public DeliveryId(double value) : base(value)
        {
        }

        override
        protected  Object createFromString(String text){
            return new Guid(text);
        }

        override
        public String AsString(){
            Guid obj = (Guid) base.ObjValue;
            return obj.ToString();
        }
        
       
        public Guid AsGuid(){
            return (Guid) base.ObjValue;
        }


    }
}