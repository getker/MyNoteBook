using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 无限滚动列表设置
public class InfinityScrollSetting : MonoBehaviour {

    // child的数量
    public int amount = 20;

    InfinityGridLayoutGroup infinityGridLayoutGroup;

	void Start () {
        infinityGridLayoutGroup = transform.GetComponentInChildren<InfinityGridLayoutGroup>();
        infinityGridLayoutGroup.SetAmount(amount);
        infinityGridLayoutGroup.updateChildrenCallback = UpdateChildrenCallback;
    }
	
    // 根据index更新内容
    void UpdateChildrenCallback(int index, Transform trans)
    {
        //Debug.Log("UpdateChildrenCallback: index=" + index + " name:" + trans.name);
        Text text = trans.Find("Text").GetComponent<Text>();
        string msg = (index * 10).ToString();
        text.text = msg;
    }

    // 外部设置
    void OnGUI()
    {
        if (GUILayout.Button("Add one item"))
        {
            infinityGridLayoutGroup.SetAmount(++amount);
        }
        if (GUILayout.Button("remove one item"))
        {
            infinityGridLayoutGroup.SetAmount(--amount);
        }
    }
}
