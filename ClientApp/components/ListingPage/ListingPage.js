import PageHeader from "../PageHeader.vue";
import Modal from "../Modal.vue";
import ImageCarousel from "../ImageCarousel.vue";
import FeatureList from "../FeatureList.vue";
import ExpandableText from "../ExpandableText.vue";

export default {
  name: 'ListingPage',
  data() {
    return {
      listing: {}
    };
  },
  methods: {
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
  },
  beforeRouteEnter(to, from, next) {
    let serverData = window.vuebnbViewModel;

    if (to.path.indexOf(serverData.Metadata.Path) > -1) {
      next(vm => {
        vm.listing = serverData.Data
      });
    } else {
      console.log("Need to get data with AJAX!");
      next(false);
    }
  }
};