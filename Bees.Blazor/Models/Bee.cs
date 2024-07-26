namespace Bees.Blazor.Models;

public abstract class Bee
{
    public bool IsDead => Health < LowestHealth;
    
    public float Health { get; private set; } = 100F;

    protected abstract float LowestHealth { get; }

    public void Damage(int amount)
    {
        if (amount is > 100 or < 0)
        {
            return;
        }
        
        if (IsDead)
        {
            return;
        }
        
        Health -= amount;
    }
}
