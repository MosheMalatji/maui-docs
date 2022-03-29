SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.WidthRequest = 120;
sfBadgeView.HeightRequest = 60;
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
sfBadgeView.BadgeText = "NEW";
Button button = new Button();
button.Text = "Primary";
button.WidthRequest = 120;
button.TextColor = Colors.Black;
button.BackgroundColor = Color.FromRgba(214, 216, 215, 255);
button.HeightRequest = 60;
sfBadgeView.Content = button;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.Position = BadgePosition.TopRight;
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;