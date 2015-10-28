
public class Character{

    private int mass;
    private int mouvementSpeed { get; set; }
    private int forceJump { get; set; }


    public Character(int m, int mvtSpeed, int fJump)
    {
        this.mass = m;
        this.mouvementSpeed = mvtSpeed;
        this.forceJump = fJump;
    }


    public int getMass()
    {
        return mass;
    }
    public void setMass(int m)
    {
        this.mass = m;
    }


}
