<template>
  <div class="image-carousel">
    <img v-bind:src="image" />
    <div class="controls">
      <carousel-control dir="left" @change-image="changeImage"></carousel-control>
      <carousel-control dir="right" @change-image="changeImage"></carousel-control>
    </div>
  </div>
</template> 

<script>
import CarouselControl from "./CarouselControl.vue";

export default {
  name: "ImageCarousel",
  props: ["images"],
  data() {
    return {
      index: 0,
      timers: {
        changeImage: ""
      }
    };
  },
  computed: {
    image() {
      return this.images[this.index % this.images.length];
    }
  },
  methods: {
    changeImage: function(interval) {
      if (interval < 2) {
        this.index +=
          this.index === 0 ? (interval === 1 ? interval : 0) : interval;
      } else {
        this.timers.changeImage = setInterval(() => {
          this.index++;
        }, interval);
      }
    }
  },
  beforeMount() {
    this.changeImage(5000);
  },
  beforeDestroy() {
    clearInterval(this.timers.changeImage);
  },
  components: {
    CarouselControl
  }
};
</script>

 <style lang="less">
.image-carousel {
  height: 100%;
  margin-top: -12vh;
  position: relative;
  display: flex;
  align-items: center;
  justify-content: center;

  .controls {
    position: absolute;
    width: 100%;
    display: flex;
    justify-content: space-between;
  }
}
</style>
