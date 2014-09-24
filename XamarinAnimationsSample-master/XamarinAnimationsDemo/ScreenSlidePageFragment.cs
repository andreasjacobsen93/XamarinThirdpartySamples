using Android.OS;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;

namespace XamarinAnimationsDemo
{
    public class ScreenSlidePageFragment : Fragment
    {
        public static string PageArg = "page";

        private int _pageNumber;

        public static ScreenSlidePageFragment Create(int pageNumber)
        {
            var fragment = new ScreenSlidePageFragment();
            var args = new Bundle();
            args.PutInt(PageArg, pageNumber);
            fragment.Arguments = args;
            return fragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _pageNumber = Arguments.GetInt(PageArg);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var rootView = (ViewGroup) inflater.Inflate(Resource.Layout.fragment_screen_slide_page, container, false);
            rootView.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "" + _pageNumber + 1;
            return rootView;
        }

        public int PageNumber
        {
            get { return _pageNumber; }
        }
    }
}