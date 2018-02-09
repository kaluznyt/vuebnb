import PageHeader from "../PageHeader.vue";
import Modal from "../Modal.vue";
import ImageCarousel from "../ImageCarousel.vue";
import FeatureList from "../FeatureList.vue";
import ExpandableText from "../ExpandableText.vue";
import routeMixin from '../../js/route-mixin'

export default {
  name: 'ListingPage',
  mixins: [routeMixin],
  data() {
    return {
      headerImage: null,
      title: null,
      about: null,
      address: null,
      amenities: [],
      prices: [],
      images: []
    };
  },
  methods: {
    assignData(listing) {
      Object.assign(this.$data, listing);
    },
    openModal() {
      this.$refs.imagemodal.modalOpen = true;
    }
  },
  components: {
    PageHeader,
    Modal,
    ImageCarousel,
    FeatureList,
    ExpandableText
  } //,
  // beforeRouteEnter(to, from, next) {
  //   let serverData = window.vuebnbViewModel;

  //   if (to.path.indexOf(serverData.Metadata.Path) > -1) {
  //     next(vm => {
  //       vm.listing = serverData.Data
  //     });
  //   } else {
  //     console.log("Need to get data with AJAX!");
  //     next(false);
  //   }
  // }
};