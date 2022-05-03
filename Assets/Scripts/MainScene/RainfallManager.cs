using UnityEngine;

public class RainfallManager : MonoBehaviour
{
    [SerializeField] private GameObject crystalPrefab, trashPrefab;
    [SerializeField] private Transform parent;
    [SerializeField] private float minTime, maxTime, minPosX, maxPosX, posY;
    private float time;
    private bool isStart = false;

    public void StartRainfall()
    {
        isStart = true;
        RollTime();
    }
    public void StopRainfall()
    {
        isStart = false;
        time = 0;
    }
    private void Update()
    {
        if (!isStart) return;

        time -= Time.deltaTime;

        if (time <= 0)
        {
            RollTime();

            CreateDrop();

            var obj = Instantiate(crystalPrefab, parent, false);
            obj.transform.localPosition = GetPos();
            obj.GetComponent<ClickObject>().ItemSet
                (new Crystal(Global.TypeOfItem.Crystal, Global.TypeOfCrystal.Strength));
        }
    }
    private void CreateDrop()
    {
        int temp = Random.Range(0, 2);

        var obj = Instantiate(crystalPrefab, parent, false);
        obj.transform.localPosition = GetPos();

        if (temp == 0)
        {
            obj.GetComponent<ClickObject>().ItemSet
                (new Trash(Global.TypeOfItem.Trash));
        }
        else
        {
            int type = Random.Range(0, 3);
            print(type);
            obj.GetComponent<ClickObject>().ItemSet
                (new Crystal(Global.TypeOfItem.Crystal, (Global.TypeOfCrystal)type));
        }
    }

    private Vector2 GetPos()
    { 
        return new Vector2(Random.Range(minPosX, maxPosX), posY);
    }
    private void RollTime()
    {
        time = Random.Range(minTime, maxTime);
    }
}
