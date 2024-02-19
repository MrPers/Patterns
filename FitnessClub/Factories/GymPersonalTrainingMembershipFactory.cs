using FitnessClub.Domain;

namespace FitnessClub.Factories
{
    internal class GymPersonalTrainingMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymPersonalTrainingMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            GymPersonalTrainingMembership membership = new(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
