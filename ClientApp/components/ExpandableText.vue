<template>
    <div>
        <p v-bind:class="{contracted: contracted}">
            <slot></slot>
        </p>
        <button class="more" v-on:click="contracted=!contracted"> {{ contracted ? "+ More" : "- Less" }}</button>
    </div>
</template>

<script>
export default {
  data() {
    return {
      contracted: true
    };
  }
};
</script>

<style lang="less">
p {
  white-space: pre-line;
}

.contracted {
  height: 250px;
  overflow: hidden;
}
.about {
  button {
    &.more {
      background: transparent;
      border: 0;
      color: #008489;
      padding: 0;
      font-size: 17px;
      font-weight: bold;
    }

    &.more:hover,
    &.more:focus,
    &.more:active {
      text-decoration: underline;
      outline: none;
    }
  }
}
</style>
