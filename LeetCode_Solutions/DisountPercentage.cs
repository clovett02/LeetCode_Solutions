using System;


namespace LeetCode_Solutions
{
    public class DiscoutPercentage
    {
        public float TotalPurchases {get; set;}
        public bool IsMember {get; set;}

        public float CalculateDiscountPercentage(float orderTotal)
        {
            var result = 0f;
            switch(orderTotal)
            {
                case var expression when 0 < orderTotal &&  orderTotal < 10000.0f:
                    result = 0.05f;
                    break;
            }
            return result;
        }
        
    }
}