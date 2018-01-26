<template>
    <div>
        <toolbar :icon="logo"></toolbar>
        <div>
            <page-header :image="headerImage" @header-clicked="openModal"></page-header>
            <div class="container">
                <div class="heading">
                    <h1>{{title}}</h1>
                    <p>{{address}}</p>
                    <hr>
                    <div class="about">
                        <h3>About this listing</h3>
                        <p v-bind:class="{contracted: contracted}">{{about}}</p>
                        <button class="more" v-on:click="contracted=!contracted"> {{ contracted ? "+ More" : "- Less" }}</button>
                    </div>
                    <div class="lists">
                        <feature-list title="Amenities">
                                <div class="list-item" v-for="amenity in amenities">
                                    <i class="fa fa-lg" v-bind:class="amenity.icon"></i>
                                    <span>{{amenity.title}}</span>
                                </div>
                        </feature-list>
                        <feature-list title="Prices">
                                    <div class="list-item" v-for="price in prices">
                                        {{ price.title }}:
                                        <strong> {{ price.value }}</strong>
                                    </div>
                        </feature-list>
                    </div>
                </div>
            </div>
            <modal ref="imagemodal">
                <image-carousel :images="Images"></image-carousel>
            </modal>
        </div>
    </div>
</template>

<script src="./app.js">
</script>
<style lang="less" src="./app.less">

</style>
