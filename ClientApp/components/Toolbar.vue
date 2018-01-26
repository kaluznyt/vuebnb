<template>
    <div id="toolbar">
        <img class="icon" :src="icon">
        <h1>vuebnb</h1>
    </div>
</template>
<script>
export default {
  name: "Toolbar",
  props: ["icon"]
};
</script>
<style lang="less">
#toolbar {
  display: flex;
  align-items: center;
  border-bottom: 1px solid #e4e4e4;
  box-shadow: 0 1px 5px rgba(0, 0, 0, 0.1);
}

#toolbar .icon {
  height: 46px;
  margin: 5px;
  display: inline-block;
}

#toolbar h1 {
  color: #4fc08d;
  display: inline-block;
  font-size: 28px;
  margin: 0;
}
</style>
