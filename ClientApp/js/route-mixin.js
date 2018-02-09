import axios from 'axios';

function getData(to) {
    return new Promise((resolve) => {
        let serverData = window.vuebnbViewModel;

        if (!serverData.path || to.path !== serverData.Path) {
            axios.get(`/api${to.path}`).then(({
                data
            }) => {
                resolve(data);
            });
        } else {
            resolve(serverData);
        }
    })
}

export default {
    beforeRouteEnter: (to, from, next) => {
        getData(to).then((data) => {
            next(component => component.assignData(data));
        })
    }
}