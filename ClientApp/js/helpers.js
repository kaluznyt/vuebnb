let groupByCountry = function (listings) {
    if (!!!listings) return {};

    return listings.reduce((countryHash, y) => {
        for (var country in countryHash) {
            if (countryHash.hasOwnProperty(country)) {
                if (y.address.indexOf(country) != -1) {
                    countryHash[country].push(y);
                    return countryHash;
                }
            }
        }
    }, {
        'Cuba': [],
        'Taiwan': [],
        'Poland': []
    });
}

export {
    groupByCountry
};