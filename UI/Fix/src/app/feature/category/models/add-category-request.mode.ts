export interface AddCategoryRequest{
    // name: string;
    // urlHandle: string;

    mechanic_name: string;
    mechanic_surname: string;
    mechanic_shop_name: string;
    mechanic_type: string;
    location: string;
    is_logged_in: boolean;
    rating: number;
    review_count: number;   
    working_hours: string;
    services_offered: string;
    profile_created_at: Date;
}