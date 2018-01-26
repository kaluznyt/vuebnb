  <template>
  <div id="modal" :class="{ show : showModal }">
    <button @click="clicked" class="modal-close"> &times; </button>
    <div class="modal-content">
      <image-carousel :images="images"></image-carousel>
    </div>
  </div>
</template>
<script>
import ImageCarousel from "../image-carousel/ImageCarousel.vue";

export default {
  name: "Modal",
  props: ["images", "showModal"],
  methods: {
    clicked() {
      this.$emit("close-image-viewer");
    }
  },
  components: { ImageCarousel }
};
</script>
<style>

</style>
