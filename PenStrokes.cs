// Draw.DrawCircle
public void DrawCircle(int x, int y, Color32 color)
{
	for (int i = 0; i < this.brushSize * this.brushSize; i++)
	{
		int num = i % this.brushSize - this.brushSize / 2;
		int num2 = i / this.brushSize - this.brushSize / 2;
		int num3 = x + num;
		int num4 = y + num2;
		if (num3 >= 0 && num3 < this.sizeX && num4 >= 0 && num4 < this.sizeY && num * num + num2 * num2 < this.brushSize * this.brushSize / 4)
		{
			float num5 = Mathf.Sqrt((float)(num * num + num2 * num2));
			float weight = 1f - num5 / (float)this.brushSize;
			Color32 c = this.BlendColors(this.textureNew.GetPixel(num3, num4), color, weight);
			this.textureNew.SetPixel(num3, num4, c);
		}
	}
}
