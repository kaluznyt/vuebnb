<template>
  <i :class="classes" @click="clicked"></i>
</template>
<script>
export default {
  name: "CarouselControl",
  props: ["dir"],
  computed: {
    classes() {
      return "image-carousel-control fa fa-2x fa-chevron-" + this.dir;
    }
  },
  methods: {
    clicked() {
      this.$emit("change-image", this.dir === "left" ? -1 : 1);
    }
  }
};
</script>
<style lang="less">
.carousel-control {
  padding: 1rem;
  color: #ffffff;
  opacity: 0.85;
}

.image-carousel-control {
  padding: 1rem;
  color: #fff;
  opacity: 0.55;
  font-size: 8rem;
}

@media (min-width: 744px) {
  .carousel-control {
    font-size: 3rem;
  }
}
</style>
