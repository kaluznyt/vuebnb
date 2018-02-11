<template>
  <div class="listing-summary-group">
    <h1>Places in {{ country }}</h1>
    <div class="listing-summaries-wrapper">
      <carousel-control dir="left"></carousel-control>
      <div class="listing-summaries">
        <listing-summary v-for="listing in listings" :key="listing.id" :listing="listing">
        </listing-summary>
      </div>
      <carousel-control dir="right"></carousel-control>
    </div>
  </div>
</template>
<script>
import ListingSummary from "./ListingSummary.vue";
import CarouselControl from "./CarouselControl.vue";

export default {
  props: ["country", "listings"],
  components: {
    ListingSummary,
    CarouselControl
  }
};
</script>

<style lang="less">
.listing-summaries-wrapper {
  display: flex;
  position: relative;
}

.image-carousel-control {
  align-self: center;
  cursor: pointer;
  padding: 0px;
  color: black;
  opacity: 0.45;
  font-size: 6rem;
  position: absolute;

  &.fa-chevron-left {
    left: -50px;
  }

  &.fa-chevron-right {
    right: -50px;
  }
}
</style>


