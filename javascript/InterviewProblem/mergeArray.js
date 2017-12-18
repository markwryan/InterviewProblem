exports.merge = function(array1, array2) {

    if(array1 == null) {
        if(array2 == null) {
            return null;
        }
        return array2;
    }

    if(array2 == null) {
        return array1;
    }

    var totalElements = array1.length + array2.length;
    var elementsRemaining = totalElements > 0;
    var mergedElements = [];
    var elementIndex = 0;

    while(elementsRemaining) {
        if(elementIndex < array1.length) {
            mergedElements.push(array1[elementIndex]);
        }

        if(elementIndex < array2.length) {
            mergedElements.push(array2[elementIndex]);
        }

        if(elementIndex >= array1.length && elementIndex >= array2.length) {
            elementsRemaining = false;
        }
        elementIndex++;
    }

    return mergedElements;
};

