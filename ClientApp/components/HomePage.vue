<template>
  <div class="home-container">
    <listing-summary-group v-for="(group,country) in listing_groups" :key="country" :listings="group" :country="country">
    </listing-summary-group>
  </div>
</template>
<script>
import { groupByCountry } from "../js/helpers";
import ListingSummaryGroup from "./ListingSummaryGroup.vue";
import axios from "axios";
import routeMixin from "../js/route-mixin";

export default {
  mixins: [routeMixin],
  data() {
    return { listing_groups: [] };
  },
  methods: {
    assignData(listings) {
      this.listing_groups = groupByCountry(listings);
    }
  },
  components: {
    ListingSummaryGroup
  }
};
</script>

<style lang="less">
.home-container {
  margin: 0 auto;
  padding: 0 25px;
}
@media (min-width: 1131px) {
  .home-container {
    width: 1080px;
  }
}

</style>
