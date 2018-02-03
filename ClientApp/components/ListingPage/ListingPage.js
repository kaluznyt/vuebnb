import PageHeader from "../PageHeader.vue";
import Modal from "../Modal.vue";
import ImageCarousel from "../ImageCarousel.vue";
import FeatureList from "../FeatureList.vue";
import ExpandableText from "../ExpandableText.vue";

const model = window.vuebnbListingModel;

const data = function () {
  return model;
};

export default {
  name: 'ListingPage',
  data: data,
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
  }
};