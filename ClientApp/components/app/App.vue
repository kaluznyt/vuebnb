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
                        <expandable-text>
                            {{about}}
                        </expandable-text>
                        <!-- <p v-bind:class="{contracted: contracted}">{{about}}</p>
                        <button class="more" v-on:click="contracted=!contracted"> {{ contracted ? "+ More" : "- Less" }}</button> -->
                    </div>
                    <div class="lists">
                        <feature-list title="Amenities" :items="amenities">
                            <template slot-scope="amenity">
                                <i class="fa fa-lg" :class="amenity.icon"></i>
                                <span>{{ amenity.title }}</span>
                            </template>
                        </feature-list>
                        <feature-list title="Prices" :items="prices">
                            <template slot-scope="price">
                                {{ price.title }}:
                                <strong> {{ price.value }}</strong>
                            </template>
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
