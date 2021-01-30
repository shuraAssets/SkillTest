
[System.Serializable]
public struct AllParams
{
    public float buffDelay;

    public int healthBuff;
    public int attackBuff;
    public int speedBuff;

    public AllParams(int hp, int atk, int spd, int delay)
    {
        healthBuff = hp;
        attackBuff = atk;
        speedBuff = spd;
        buffDelay = delay;
    }
}