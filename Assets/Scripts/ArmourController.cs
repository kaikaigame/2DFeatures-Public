using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArmourController : MonoBehaviour
{
    public List<UnityEngine.U2D.Animation.SpriteResolver> spriteResolvers = new List<UnityEngine.U2D.Animation.SpriteResolver>();

    public GameObject item;//�����ϵı�������
    UnityEngine.U2D.Animation.SpriteResolver bodyResolver;//�����л��Ĳ���

    void Start()
    {
        foreach (var resolver in FindObjectsOfType<UnityEngine.U2D.Animation.SpriteResolver>())
        {
            spriteResolvers.Add(resolver);

            if (resolver.GetCategory() == "Body")
            {
                bodyResolver = resolver;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach (var resolver in FindObjectsOfType<UnityEngine.U2D.Animation.SpriteResolver>())
            {
                resolver.SetCategoryAndLabel(resolver.GetCategory(), "armour");
            }

            //ʵ�������崩��װ����ʱ����ʾ��������
            if (bodyResolver.GetLabel() == "armour")
            {
                item.SetActive(false);
            }

            if (bodyResolver.GetLabel() == "normal")
            {
                item.SetActive(true);
            }
        }
    }
}