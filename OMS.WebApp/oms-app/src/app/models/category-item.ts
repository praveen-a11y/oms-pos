    import{Item} from './item';
    
    export interface CategoryItem {
        outletId: number;
        itemCategoryId: number;
        itemCategoryName: string;
        items: Item[];
    }