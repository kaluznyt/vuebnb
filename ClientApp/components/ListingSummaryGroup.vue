<template>
  <div class="listing-summary-group">
    <h1>Places in {{ country }}</h1>
    <div class="listing-summaries-wrapper">
      <carousel-control dir="left" @change-image="change" :style="leftArrowStyle"></carousel-control>
      <div style="overflow:hidden">
        <div class="listing-summaries" :style="style">
          <listing-summary v-for="listing in listings" :key="listing.id" :listing="listing">
          </listing-summary>
        </div>
      </div>
      <carousel-control dir="right" @change-image="change" :style="rightArrowStyle"></carousel-control>
    </div>
  </div>
</template>
<script>
import ListingSummary from "./ListingSummary.vue";
import CarouselControl from "./CarouselControl.vue";

const listingSummaryWidth = 365;
const listingsPerRow = 3;

export default {
  props: ["country", "listings"],
  data() {
    return {
      offset: 0
    };
  },
  methods: {
    change(val) {
      let newVal = this.offset + parseInt(val);
      if (newVal >= 0 && newVal <= this.listings.length - listingsPerRow) {
        this.offset = newVal;
      }
    }
  },
  computed: {
    leftArrowStyle() {
      return {
        visibility: this.offset > 0 ? "visible" : "hidden"
      };
    },
    rightArrowStyle() {
      return {
        visibility:
          this.offset < this.listings.length - listingsPerRow
            ? "visible"
            : "hidden"
      };
    },
    style() {
      return {
        transform: `translateX(${this.offset * -listingSummaryWidth}px)`
      };
    }
  },
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

.listing-summary-group {
  padding-bottom: 20px;
}

.listing-summaries {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  transition: transform 0.9s;

  & > .listing-summary {
    margin-right: 15px;
  }
  & > .listing-summary:last-child {
    margin-right: 0;
  }
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


