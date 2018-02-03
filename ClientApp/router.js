import Vue from 'vue';
import VueRouter from 'vue-router';
Vue.use(VueRouter);

import ListingPage from './components/ListingPage/ListingPage.vue';

export default new VueRouter({
    mode: 'history',
    routes: [{
        path: '/listing/:listing',
        component: ListingPage,
        name: 'listing'
    }]
});