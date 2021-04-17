namespace FarmSystem.Test1
{
    /// <summary>
    /// Farm Animal
    /// </summary>
    /// <remarks>An abstract class so that this class cannot be used to create objects</remarks>
    public abstract class FarmAnimal : IFarmAnimal
    {
        /// <summary>
        /// Farm Animal Id 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Number of Legs that this Farm Animal has
        /// </summary>
        public int NoOfLegs { get; set; }

        /// <summary>
        /// Make the Animal Talk
        /// </summary>
        /// <remarks>All Animals must be able to talk</remarks>
        public abstract void Talk();


        // Note: Walk and Run Actions are not used in the exercise tests
        // Making them optional for the derived class to implement.

        /// <summary>
        /// Make the Animal Walk
        /// </summary>
        /// <remarks>Optional that the animal can Walk</remarks>
        public virtual void Walk() { }

        /// <summary>
        /// Make the Animal Run
        /// </summary>
        /// <remarks>Optional that the animal can Run</remarks>
        public virtual void Run() { }
    }
}