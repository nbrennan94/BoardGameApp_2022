using API_with_EF.Models;

namespace API_with_EF.DAL
{
    public class FishRepository
    {
        private GameContext _dbContext = new GameContext();

        public Fish AddFish(Fish fishToAdd)
        {
            _dbContext.Add(fishToAdd);
            _dbContext.SaveChanges();

            return GoFishingForLatest();
        }

        public Fish GoFishingForLatest()
        {
            return _dbContext.Fishes.OrderByDescending(fish => fish.Id).FirstOrDefault();
        }

        pu
    }
}
