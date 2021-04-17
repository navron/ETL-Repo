namespace FarmSystem.Test1
{
    public interface  IFarmAnimal
    {
        /// <summary>
        /// Farm Animal Id 
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Number of Legs that this Farm Animal has
        /// </summary>
        int NoOfLegs { get; set; }

        /// <summary>
        /// Make the Animal Talk 
        /// </summary>
        void Talk();

        /// <summary>
        /// Make the Animal Walk 
        /// </summary>
        void Walk();

        /// <summary>
        /// Make the Animal Run 
        /// </summary>
        void Run();
    }
}