<template>
  <div id="toolbar">
    <router-link :to="{name: 'home'}">
      <img class="icon" :src="logo">
      <h1>vuebnb</h1>
    </router-link>
  </div>
</template>
<script>
import logo from "../../wwwroot/Images/logo.png";

export default {
  name: "Toolbar",
  data() {
    return {
      logo: logo
    };
  }
};
</script>
<style lang="less">
#toolbar {
  display: flex;
  align-items: center;
  border-bottom: 1px solid #e4e4e4;
  box-shadow: 0 1px 5px rgba(0, 0, 0, 0.1);

  a {
    display: flex;
    align-items: center;
    text-decoration: none;
  }

  .icon {
    height: 5rem;
    width: 5rem;
    margin: 5px;
    display: inline-block;
  }

  h1 {
    font-family: "Open Sans", sans-serif;
    font-weight: bold;
    color: #4fc08d;
    display: inline-block;
    font-size: 28px;
    margin: 0;
  }
}
</style>
