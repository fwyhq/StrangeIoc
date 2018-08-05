//  -----------------------------------------------------------------------
//   <copyright file="Study1Context.cs" company="Tencent">
//   Copyright (C) Tencent. All Rights Reserved.
//   </copyright>
//   <author>leowfeng(冯伟)</author>
//   <summary></summary>
//  -----------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.View.ImageGame
{
    public class ImageGameView:strange.extensions.mediation.impl.View
    {
        public int ImagePart;
        public GameObject ImageTemplete;

        private GameObject[] ImageAreas;
        private GameObject[] ImageAnswers;
        public GameObject AreaParent;
        public GameObject AnswerParent;

        public void SetGameImage(ImageProperty property)
        {
            this.ClearArea();
            int imageCount = property.images.Length;
            Sprite firstImage = property.images[0];
            this.InitCardArea(firstImage.texture.height, firstImage.texture.width, imageCount);
            this.InitAnswer(property.images);
        }

        private void InitCardArea(float totalHeight, float totalWidth, int count)
        {
            float col = Mathf.Sqrt(count);
            float height = totalHeight / col;
            float width = totalWidth / col;
            ImageAreas = new GameObject[(int)count];
            for (int i = 0; i < count; i++)
            {   
                var go = Instantiate(ImageTemplete);
                go.transform.SetParent(AreaParent.transform);
                var item = go.GetComponent<ImageAreaItem>();
                item.SetSize(height, width);
                item.SetIndex(i);
                ImageAreas[i] = go;
            }

            this.SortCardArea(totalHeight, totalWidth, (int)col, height, width);
        }

        private void SortCardArea(float totalHeight,float totalWidth , int col , float height,float width)
        {
            float right = totalWidth / 2;
            float up = totalHeight / 2;
            Vector2 startPos = new Vector2( - right / 2, up / 2);
            for (int i = 0; i < col * col; i++)
            {
                    ImageAreas[i].transform.localPosition =
                        new Vector2(startPos.x  + (i % col) * width, startPos.y - (i / col) * height);
            }
        }

        private void InitAnswer(Sprite[] sprites)
        {
            ImageAnswers = new GameObject[(int)sprites.Length];
            for (int i = 0; i < sprites.Length; i++)
            {
                var go = Instantiate(ImageTemplete);
                go.transform.SetParent(AnswerParent.transform);
                var item = go.GetComponent<ImageAreaItem>();
                item.SetSize(sprites[i].rect.height, sprites[i].rect.width);
                item.SetIndex(i, 1);
                item.SetSprite(sprites[i]);
                ImageAnswers[i] = go;
            }
            this.SortAnswer(sprites[0].rect.height, sprites[0].rect.width);
        }

        private void SortAnswer(float height, float width)
        {
            var group = AnswerParent.GetComponent<GridLayoutGroup>();
            group.cellSize = new Vector2(width, height);
        }

        private void ClearArea()
        {
            if (ImageAreas != null)
            {
                for (int i = 0; i < ImageAreas.Length; i++)
                {
                    Destroy(ImageAreas[i]);
                }
            }
            
        }
    }
}