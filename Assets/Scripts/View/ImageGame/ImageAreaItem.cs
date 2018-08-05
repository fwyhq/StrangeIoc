//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.View.ImageGame
{
    public class ImageAreaItem:MonoBehaviour,IDragHandler,IEndDragHandler,IBeginDragHandler
    {
        public BoxCollider2D Collider;
        public Image Source;
        public RectTransform RectTran;
        private int index;
        private int type;
        private bool isStay;
        private ImageAreaItem collider;
        public void SetSize(float height, float width)
        {
            var size = new Vector2(width,height);
            Collider.size = size / 6;
            RectTran.sizeDelta = size;
        }

        public void SetIndex(int index ,int type = 0)
        {
            this.index = index;
            this.type = type;
        }

        public void SetSprite(Sprite sp)
        {
            Source.sprite = sp;
        }

        void OnTriggerEnter2D(Collider2D collider)
        {
            var item = collider.GetComponent<ImageAreaItem>();

            if (item.type != this.type && item.index == this.index)
            {
                this.collider = item;
                this.isStay = true;
            }
        }

        void OnTriggerExit2D(Collider2D collider)
        {
            var item = collider.GetComponent<ImageAreaItem>();

            if (item.type != this.type && item.index == this.index)
            {
                this.collider = null;
                this.isStay = false;
            }
        }   

        public void OnDrag(PointerEventData eventData)
        {
            if (this.type != 0)
            {
                this.transform.position = eventData.position;
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (this.type != 0 && this.collider != null && this.collider.isStay)
            {
                this.collider.SetSprite(this.Source.sprite);
                this.gameObject.SetActive(false);
            }
        }

        public void OnBeginDrag(PointerEventData eventData)
        {

        }
    }
}