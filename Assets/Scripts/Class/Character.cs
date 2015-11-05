
public class Character{

    private int mass;
    private int mouvementSpeed { get; set; }
    private int forceJump { get; set; }
    private bool touchingTheFloor;


    public Character(int m, int mvtSpeed, int fJump, bool touchFloor)
    {
        this.mass = m;
        this.mouvementSpeed = mvtSpeed;
        this.forceJump = fJump;
        this.touchingTheFloor = touchFloor;
    }


    public int getMass()
    {
        return mass;
    }
    public void setMass(int m)
    {
        this.mass = m;
    }

    public void setTouchingTheFloor(bool touchFloor){
        this.touchingTheFloor = touchFloor;
    }

    public bool isTouchingTheFloor()
    {
        return touchingTheFloor;
    }


}
