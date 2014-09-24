using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Android.Util;

namespace Control
{
	class ProgressCircleView: View
	{

		private Paint mPaintSuperior;
		private Paint mPaintFondo;
		private Paint mPaintTexto;
		private Typeface mFace;
		int porcentaje=0;
		int por_rango=20;

		public ProgressCircleView(Context context) : base(context)
		{
			Initialize ();
		}

		public ProgressCircleView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			Initialize ();
		}

		public ProgressCircleView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			Initialize ();
		}


		private void Initialize ()
		{
			Focusable = true;

			mPaintFondo = new Paint();
			mPaintFondo.AntiAlias = true;

			mPaintSuperior = new Paint();
			mPaintSuperior.AntiAlias = true;

			mPaintTexto = new Paint();
			mPaintTexto.AntiAlias = true;
			mPaintTexto.TextAlign = Paint.Align.Center;
			mFace =Typeface.CreateFromAsset(Application.Context.Assets , "fonts/Sansation_Light.ttf");
		}


		protected override void OnDraw(Canvas canvas)
		{
			drawPorcentajeOnCanvas(canvas);
		}

		private void drawPorcentajeOnCanvas(Canvas canvas)
		{
			base.OnDraw (canvas);

			canvas.Save ();

			canvas.DrawColor(Android.Graphics.Color.White);

			//Obtenemos el centro de nuesto canvas
			float x = this.MeasuredWidth / 2;
			float y = this.MeasuredHeight / 2;

			//Obtenemos el radio R1
			//Obtenemos el radio R2
			float R1 = 0;
			float R2 = 0;
			//if (canvas.Width < canvas.Height) {
			if (this.MeasuredWidth  < this.MeasuredHeight) {
				R1 = x;//Obtenemos el radio R1
				R2 = x-(x*por_rango/100);
			} else {
				R1 = y ;//Obtenemos el radio R1
				R2 = y-(y *por_rango/100);//Obtenemos el radio R2 que dejamos un 20% de margen

			}

			//Dibujamos el fondo de nuestro grafico que va ir creciendo de acuerdo al porcentaje descargado
			RectF rectF2 = new RectF(x-R1, y-R1,x+R1, y+R1);
			mPaintFondo.Color= Android.Graphics.Color.Rgb(19,184,213);

			int grados = 0;
			grados = 360 * porcentaje / 100;
			canvas.DrawArc(rectF2, 270, grados, true, mPaintFondo);

			//Fondo superior de nuestro texto
			mPaintSuperior.Color= Android.Graphics.Color.Rgb(50,58,69);
			canvas.DrawCircle(x,y , R2, mPaintSuperior);


			//Texto que nos indica el procentaje descargado
			mPaintTexto.SetTypeface (mFace);
			mPaintTexto.Color = Color.White;

			//Obtenemos el 30 % de radio de nuestro circulo de fondo, el cual sera el tamaño de letra utilzar;
			float MYTEXTSIZE = R2 *30/100;
			// Get the screen's density scale
			float scale = Application.Context.Resources.DisplayMetrics.Density;
			//Convert the dps to pixels, based on density scale
			int textSizePx = (int) (MYTEXTSIZE * scale + 0.5f);
			mPaintTexto.TextSize = textSizePx;

			//Obtenemos la posicion para centrar adecuadamente nuesto texto
			int xPos = (this.MeasuredWidth  / 2);
			int yPos = (int) ((this.MeasuredHeight / 2) - ((mPaintTexto.Descent() + mPaintTexto.Ascent()) / 2)) ; 

			string Texto_Porcentaje =porcentaje.ToString();
			canvas.DrawText (Texto_Porcentaje+" %", xPos,yPos, mPaintTexto);

			canvas.Restore();
		}

		public void setPorcentaje(int _porcentaje) {
			porcentaje = _porcentaje;
			Invalidate ();
		}
	}
}

