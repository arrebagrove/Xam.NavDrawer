using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;

using DK.Ostebaronen.Droid.ViewPagerIndicator;

using NavDrawer.Adapters;
using Fragment = Android.Support.V4.App.Fragment;

namespace NavDrawer.Fragments
{
    public class FriendsFragment : Fragment
    {
        private ViewPager m_ViewPager;
        private TabPageIndicator m_PageIndicator;
        private FragmentPagerAdapter m_Adapter;

        public FriendsFragment()
        {
            this.RetainInstance = true;
        }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.fragment_friends, null);

            // Create your application here
            this.m_ViewPager = view.FindViewById<ViewPager>(Resource.Id.viewPager);
            this.m_ViewPager.OffscreenPageLimit = 4;
            this.m_PageIndicator = view.FindViewById<TabPageIndicator>(Resource.Id.viewPagerIndicator);

            //Since we are a fragment in a fragment you need to pass down the child fragment manager!
            this.m_Adapter = new FriendsAdapter(this.ChildFragmentManager);


            this.m_ViewPager.Adapter = this.m_Adapter;

            this.m_PageIndicator.SetViewPager(this.m_ViewPager);
            this.m_PageIndicator.CurrentItem = 0;
            return view;
        }

    }
}