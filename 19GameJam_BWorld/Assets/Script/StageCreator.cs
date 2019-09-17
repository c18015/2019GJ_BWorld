using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class StageCreator : MonoBehaviour
{
    public TextAsset textAsset;

    //配置するオブジェクト
    public GameObject block;
    public GameObject player;

    public Vector3 createPos;

    public Vector3 spaceScale = new Vector3(1.0f, 1.0f, 0f);

    static bool create = true;

    void Start()
    {
        if (create)
        {
            CreateStage(createPos);

            createPos = Vector3.zero;
        }
        
    }

    void CreateStage(Vector3 pos)
    {
        create = false;

        Vector3 originPos = pos;
        string stageTextData = textAsset.text;

        foreach (char c in stageTextData)
        {

            GameObject obj = null;

            if (c == '#')
            {
                obj = Instantiate(block, pos, Quaternion.identity) as GameObject;
                obj.name = block.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'p')
            {
                obj = Instantiate(player, pos, Quaternion.identity) as GameObject;
                obj.name = player.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == '\n')
            {
                pos.y -= spaceScale.y;
                pos.x = originPos.x;
            }
            else if (c == ' ')
            {
                pos.x += spaceScale.x;
            }
        }
    }
}