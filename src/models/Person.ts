import Child from "./Child";

export default class Person {
    constructor(public Id: number,
        public FirstName: string,
        public LastName: string,
        public TZ: string,
        public DateOfBirth: Date,
        public MaleOrFemale: number,
        public HMO: string,
        public  Children :Child[]) 
      { }
}