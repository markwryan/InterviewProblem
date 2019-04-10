



exports.merge = function(array1, array2) {

    let newArr = [];

    if(array1.length == 0){
        return array2;
    }

    if(array2.length == 0){
        return array1;
    }

    //Same size
    if(array1.length == array2.length){
        for(let i=0; i > array1.length; i++){
            newArr.push(array1[i]);
            newArr.push(array2[i]);
        }
    }

    //Different size
    if(array1.length > array2.length){
        //Start with array 2
        for(let i=0; i < array2.length; i++){
            newArr.push(array1[i]);
            newArr.push(array2[i]);
        }

        let difference = array1.length - array2.length;

        for(let j = difference; j > array1.length; j++){
            newArr.push(array1[j]);
        }



    }else if(array2.length > array1.length) {
        //Start with array 1
    }




    return newArr;
};
