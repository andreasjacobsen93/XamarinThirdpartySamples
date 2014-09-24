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
using Android.Graphics.Drawables;
using Android.Util;
using Android.Content.Res;

namespace CustomControl
{
	class CircleImageView: ImageView 
	{

		//VARIABLE DE COLOR
		Color Color_Fondo;

		public CircleImageView(Context context) : base(context)
		{
			Initialize ();
		}

		public CircleImageView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			//RECUPERAMOS ID DE LOS ELEMENTOS DEL ESTILO ASIGNADOS
			int[] styleAttrs = Resource.Styleable.CircleImageView;		
			//OBTENEMOS LOS ATRIBUTOS A PARTIR DE LOS ID
			TypedArray a = context.ObtainStyledAttributes(attrs, styleAttrs);
			//RECUPERAMOS EL ATRIBUTO QUE NOS INTERESA 
			Color_Fondo = a.GetColor(Resource.Styleable.CircleImageView_color_fondo_circulo, 0);
			//			a.Recycle ();
			Initialize ();





		}

		/*
		public CircleImageView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			int[] styleAttrs = Resource.Styleable.CircleImageView;		
			TypedArray a = context.ObtainStyledAttributes(attrs, styleAttrs);
			Color_Fondo = a.GetColor(Resource.Styleable.CircleImageView_color_fondo_circulo, 0);
			a.Recycle ();

			Initialize ();
		}*/

		private void Initialize ()
		{

		}


		protected override void OnDraw(Canvas canvas)
		{

			//VERIFICAMOS QUE LA VISTA TENGA UN ANCHO Y UN ALTO
			if (Width == 0 || Height == 0) {
				return; 
			}

			//DEFINIMOS LA BROCHA DE ESTILO QUE LE VAMOS A DAR A NUESTRO CIRCULO DE FONDO DE NUESTRO CONTROL
			Paint mPaintFondo;
			mPaintFondo = new Paint();
			mPaintFondo.AntiAlias = true;
			//LE ASIGNAMOS UN COLOR BASE
			//mPaintFondo.Color= Android.Graphics.Color.Rgb(255,255,255);
			mPaintFondo.Color = Color_Fondo;

			//AHORA VAMOS A SACAR EL PUNTO CENTRAL DE NUESTRA VISTA
			float cx = this.MeasuredWidth / 2;
			float cy = this.MeasuredHeight / 2;

			//SACAMOS EL RADIO DE NUESTRO CIRCULO Y LE QUITAMOS UN PORCENTAJE MINIMA DE DISTANCIA PARA TENER UN RANGO DE MARGEN 
			//CON RESPECTO A LOS LIMITES DE NUESTRO CONTROL
			float Radio=cx-(cx *5/100);

			//SI EL ANCHO ES MAYOR QUE EL ALTO DE NUESTRA VISTA RECONFIGURAMOS EL RADIO DE NUESTRO CIRCULO DE LO CONTRARIO SE
			//SALDRA DE PROPORCION
			if (cx > cy) {
				Radio=cy-(cy *5/100);

			}

			//DIBUJAMOS EL CIRCULO QUE NOS VA SERVIR DE FONDO
			canvas.DrawCircle(cx,cy , Radio, mPaintFondo);

			//CONVERTIMOS NUESTRA  VISTA DISPONIBLE(DRAWABLE) EN UN BITMAP DRAWABLE CON EL CUAL TRABAJAREMOS
			BitmapDrawable drawable = (BitmapDrawable) Drawable ;
			//VERIFICAMOS QUE NO SEA UN OBJETO NULL
			if (drawable == null) {
				return;
			}

			//RECOBRAMOS NUESTRO BITMAP(IMAGEN ASIGNADA) DEL BITMAP DRAWABLE
			Bitmap fullSizeBitmap = drawable.Bitmap;

			//RECUPERAMOS EL ANCHO Y ALTO DE NUESTRO CONTROL
			int scaledWidth = this.MeasuredWidth;
			int scaledHeight = this.MeasuredHeight;

			//IGUAL QUE HICIMOS CON EL CIRCULO VERIFICAMOS SI EL ANCHO ES MAYOR AL ALTO PARA OBTENER LA MEDIDA ADECUADA
			//PARA NUESTRA IMAGEN Y NO QUEDE DESPROPORCIONADA
			if (scaledWidth > scaledHeight) {
				scaledWidth = scaledHeight;
			}

			//INCIALIZAMOS EL PORCENTAJE QUE LE RESTAREMOS A NUESTRO RADIO DEL CIRCULO DE LA IMAGEN
			float PorcentajeCircularImagen =(float ) 0.10;

			//DEFINIMOS UNA VARIABLE BITMAP LA CUAL SERA ESCALADA PARA SU CORRECTA VISUALIZACION
			Bitmap mScaledBitmap;

			// ASIGNAMOS LA NUEVAS MEDIAS PARA ESCALAR NUESTRA IMAGEN
			scaledWidth=scaledWidth-(int)(scaledWidth*PorcentajeCircularImagen);
			//ASIGNAMOS EL ALTO Y ANCHO SEAN IGUALES YA QUE QUERESMOS UN IMAGEN CUADRADA
			scaledHeight = scaledWidth;

			//ESCALAMOS LA IMAGEN ORIGINAL Y LA ASIGNAMOS A LA VARIABLE
			mScaledBitmap= Bitmap.CreateScaledBitmap(fullSizeBitmap, scaledWidth, scaledHeight,true);

			//FUNCION QUE NOS REGRESA LA IMAGEN PRINCIPAL DENTRO DE UN CIRCULO
			Bitmap circleBitmap = getCircleBitmap (Context, mScaledBitmap, scaledWidth, scaledHeight);

			//YA QUE TENEMOS NUESTRA IMAGEN "CORTADA", VAMOS A OBTENER LOS PUNTOS PONDE VAMOS A COLOCARLA
			int px=(int) round (cx - scaledWidth / 2, 0);
			int py=(int) round (cy - scaledWidth / 2, 0);

			//DIBUJAMOS NUESTRA IMAGEN EN LA POSICION ADECUADA
			canvas.DrawBitmap(circleBitmap, px, py, null);


		}



		public static Bitmap getCircleBitmap(Context context, Bitmap input, int w , int h) 
		{
			//CREAMOS UN BITMAP TEMP CON LAS DIMENSIONES QUE LE PASAMOS
			Bitmap output = Bitmap.CreateBitmap(w, h, Bitmap.Config.Argb8888);
			//CRAMOS UN CANVAS EL CUAL NOS PERMITIRA DIBUJAR EL CIRCULO QUE NOS SERVIRA COMO MASCARA Y LE ASIGNAMOS EL BITMAP
			Canvas canvas = new Canvas(output);
			canvas.DrawARGB(0, 255, 0, 0);


			//DEFINIMOS UNA BROCHA YA QUE ES NECESARIA PARA DIBUJAR EL CIRCULO 
			Paint paint = new Paint();
			paint.AntiAlias=true;
			//string color = "#ff0002";
			//paint.Color=Color.ParseColor (color);

			//DIBUJAMOS EL CIRCULO DENTRO DEL CANVAS 
			canvas.DrawCircle(canvas.Height /2,canvas.Height /2,canvas.Height /2, paint);


			//LE APLICAMOS UN FILTRO A NUESTRA BROCHA PARA QUE CUANDO SE CONBINEN LOS ELEMENTOS DE LA IMAGEN ORIGINAL CON LA DIBUJADA EN EL CANVAS
			//ESTA APLIQUE EL RECORTE DE LA MASCARA
			paint.SetXfermode(new PorterDuffXfermode(PorterDuff.Mode.SrcIn));

			//LE ASIGNAMOS AL FONDO DE NUESTRO CANVAS LA IMAGEN QUE QUEREMOS QUE SE APLIQUE LA MASCARA, EN ESTE CASO ES LA IMAGEN
			//QUE SE LE ASIGNO AL CONTROL
			canvas.DrawBitmap(input, 0,0, paint);

			//REGRESAMOS LA IMAGEN YA RECOTADA 
			return output;
		}


		// FUNCION QUE REALIZA REDONDEO SIN DECIMALES
		public double round(double val, int places) {
			long factor = (long)Math.Pow(10,places);
			val = val * factor;
			double tmp = Math.Round(val);
			return (double)tmp / factor;
		}

	}
}

