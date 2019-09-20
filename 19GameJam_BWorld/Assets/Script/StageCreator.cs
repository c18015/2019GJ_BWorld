using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class StageCreator : MonoBehaviour
{
    public TextAsset textAsset;

    //配置するオブジェクト
    
    public GameObject player;
    public GameObject Glay_block;
    public GameObject Black_block;
    public GameObject White_block;
    public GameObject Black_Needle;
    public GameObject White_Needle;
    public GameObject Move_Block;
    public GameObject Naraku_Block;
    public GameObject Original_Block;
    public GameObject Original_Block2;
    public GameObject Original_Block3;

    public Vector3 createPos;

    public Vector3 spaceScale = new Vector3(1.0f, 1.0f, 0f);

    static bool create = true;

   public void Awake()
    {
        
        CreateStage(createPos);

        createPos = Vector3.zero;
        

        
    }

    void CreateStage(Vector3 pos)
    {
        

        Vector3 originPos = pos;
        string stageTextData = textAsset.text;

        foreach (char c in stageTextData)
        {

            GameObject obj = null;

            if (c == '#')
            {
                obj = Instantiate(Glay_block, pos, Quaternion.identity) as GameObject;
                obj.name = Glay_block.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'p')
            {
                obj = Instantiate(player, pos, Quaternion.identity) as GameObject;
                obj.name = player.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'b')
            {
                obj = Instantiate(Black_block, pos, Quaternion.identity) as GameObject;
                obj.name = Black_block.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'w')
            {
                obj = Instantiate(White_block, pos, Quaternion.identity) as GameObject;
                obj.name = White_block.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'k')
            {
                obj = Instantiate(Black_Needle, pos, Quaternion.identity) as GameObject;
                obj.name = Black_Needle.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 's')
            {
                obj = Instantiate(White_Needle, pos, Quaternion.identity) as GameObject;
                obj.name = White_Needle.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == 'm')
            {
                obj = Instantiate(Move_Block, pos, Quaternion.identity) as GameObject;
                obj.name = Move_Block.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == '_')
            {
                obj = Instantiate(Naraku_Block, pos, Quaternion.identity) as GameObject;
                obj.name = Naraku_Block.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == '1')
            {
                obj = Instantiate(Original_Block, pos, Quaternion.identity) as GameObject;
                obj.name = Original_Block.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == '2')
            {
                obj = Instantiate(Original_Block2, pos, Quaternion.identity) as GameObject;
                obj.name = Original_Block2.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if (c == '3')
            {
                obj = Instantiate(Original_Block3, pos, Quaternion.identity) as GameObject;
                obj.name = Original_Block3.name;
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