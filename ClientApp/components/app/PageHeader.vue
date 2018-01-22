<template>
  <div class="header">
    <div class="header-img" @click="clicked" :style="{ 'background-image': 'url('+ image+')'}">
      <button class="view-photos">View Photos</button>
    </div>
  </div>
</template>
<script>
export default {
  name: "PageHeader",
  props: ["image"],
  methods: {
    clicked() {
      this.$emit("open-image-viewer");
    }
  }
};
</script>
<style lang="less">
.header {
  height: 320px;
}

.header {
  .header-img {
    background-repeat: no-repeat;
    background-size: cover;
    background-position: 50% 50%;
    background-color: #f5f5f5;
    height: 100%;
    cursor: pointer;
    position: relative;
  }
}
</style>
