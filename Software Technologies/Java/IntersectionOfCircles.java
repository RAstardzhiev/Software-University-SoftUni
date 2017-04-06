import java.util.Scanner;

public class IntersectionOfCircles {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Circle firstCircle = new Circle(new Point(scanner.nextDouble(), scanner.nextDouble()), scanner.nextDouble());
        Circle secondCircle = new Circle(new Point(scanner.nextDouble(), scanner.nextDouble()), scanner.nextDouble());

        System.out.println(firstCircle.Intersect(secondCircle) ? "Yes" : "No");
    }

    public static class Circle {
        private Point Center;
        private double Radius;

        public Circle(Point center, double radius) {
            Center = center;
            Radius = radius;
        }

        public double getRadius() {
            return Radius;
        }

        public void setRadius(double radius) {
            Radius = radius;
        }

        public Point getCenter() {
            return Center;
        }

        public void setCenter(Point center) {
            Center = center;
        }

        public boolean Intersect(Circle circle) {
            double centersDistance = this.getCenter().Distance(circle.getCenter());
            double radiusCommonLength = this.getRadius() + circle.getRadius();

            if (centersDistance <= radiusCommonLength) {
                return true;
            }
            else {
                return false;
            }
        }
    }

    public static class Point {
        private double X;
        private double Y;

        public Point(double x, double y) {
            X = x;
            Y = y;
        }

        public double getY() {
            return Y;
        }

        public void setY(double y) {
            Y = y;
        }

        public double getX() {
            return X;
        }

        public void setX(double x) {
            X = x;
        }

        public double Distance(Point point) {
            double x = this.getX() - point.getX();
            double y = this.getY() - point.getY();
            return Math.sqrt((x * x) + (y * y));
        }
    }
}
